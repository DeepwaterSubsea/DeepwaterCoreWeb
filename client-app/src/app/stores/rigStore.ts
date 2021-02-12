import { makeAutoObservable, runInAction } from "mobx"
import agent from "../api/agent";
import { Rig } from "../models/rig"
import { v4 as uuid } from 'uuid'

export default class RigStore {

    rigRegistry = new Map<string, Rig>();
    selectedRig: Rig | undefined = undefined;
    editMode = false;
    loading = false;
    loadingInitial = true;

    constructor() {
        makeAutoObservable(this)
    }

    get rigsByName() {
        return Array.from(this.rigRegistry.values()).sort((a, b) => a.name.localeCompare(b.name))
    }

    loadRigs = async () => {
        try {
            (await agent.Rigs.list()).forEach(rig => {
                this.rigRegistry.set(rig.id, rig);
            });
            this.setLoadingInitial(false)
        } catch (error) {
            console.log(error);
            this.setLoadingInitial(false)
        }
    }

    setLoadingInitial = (state: boolean) => {
        this.loadingInitial = state
    }

    selectRig = (id: string) => {
        this.selectedRig = this.rigRegistry.get(id)
    }

    cancelSelectedRig = () => {
        this.selectedRig = undefined
    }

    openForm = (id?: string) => {
        id ? this.selectRig(id) : this.cancelSelectedRig();
        this.editMode = true
    }

    closeForm = () => {
        this.editMode = false
    }

    createRig = async (rig: Rig) => {
        this.loading = true;
        rig.id = uuid()
        try {
            await agent.Rigs.create(rig)
            runInAction(() => {
                this.rigRegistry.set(rig.id, rig);
                this.selectedRig = rig;
                this.editMode = false;
                this.loading = false
            })
        } catch (error) {
            console.log(error)
            runInAction(() => {
                this.loading = false
            })
        }
    }

    updateRig = async (rig: Rig) => {
        this.loading = true;
        try {
            await agent.Rigs.update(rig)
            runInAction(() => {
                this.rigRegistry.set(rig.id, rig);
                this.selectedRig = rig;
                this.editMode = false;
                this.loading = false
            })
        } catch (error) {
            console.log(error)
            runInAction(() => {
                this.loading = false
            })
        }
    }

    deleteRig = async (id: string) => {
        this.loading = true
        try {
            await agent.Rigs.delete(id)
            runInAction(() => {
                this.rigRegistry.delete(id)
                if (this.selectedRig?.id === id) this.cancelSelectedRig()
                this.loading = false
            })
        } catch (error) {
            this.loading = false
        }
    }
}