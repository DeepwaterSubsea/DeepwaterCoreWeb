import { makeAutoObservable, runInAction } from "mobx"
import agent from "../api/agent";
import { RigOperator } from "../models/rigOperator"
import { v4 as uuid } from 'uuid'

export default class RigOperatorStore {

    rigOperatorRegistry = new Map<string, RigOperator>();
    selectedRigOperator: RigOperator | undefined = undefined;
    editMode = false;
    loading = false;
    loadingInitial = true;

    constructor() {
        makeAutoObservable(this)
    }

    get rigOperatorsByName() {
        return Array.from(this.rigOperatorRegistry.values()).sort((a, b) => a.name.localeCompare(b.name))
    }

    loadRigOperators = async () => {
        try {
            (await agent.RigOperators.list()).forEach(rigOperator => {
                this.rigOperatorRegistry.set(rigOperator.id, rigOperator);
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

    selectRigOperator = (id: string) => {
        this.selectedRigOperator = this.rigOperatorRegistry.get(id)
    }

    cancelSelectedRigOperator = () => {
        this.selectedRigOperator = undefined
    }

    openForm = (id?: string) => {
        id ? this.selectRigOperator(id) : this.cancelSelectedRigOperator();
        this.editMode = true
    }

    closeForm = () => {
        this.editMode = false
    }

    createRigOperator = async (rigOperator: RigOperator) => {
        this.loading = true;
        rigOperator.id = uuid()
        try {
            await agent.RigOperators.create(rigOperator)
            runInAction(() => {
                this.rigOperatorRegistry.set(rigOperator.id, rigOperator);
                this.selectedRigOperator = rigOperator;
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

    updateRigOperator = async (rigOperator: RigOperator) => {
        this.loading = true;
        try {
            await agent.RigOperators.update(rigOperator)
            runInAction(() => {
                this.rigOperatorRegistry.set(rigOperator.id, rigOperator);
                this.selectedRigOperator = rigOperator;
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

    deleteRigOperator = async (id: string) => {
        this.loading = true
        try {
            await agent.RigOperators.delete(id)
            runInAction(() => {
                this.rigOperatorRegistry.delete(id)
                if (this.selectedRigOperator?.id === id) this.cancelSelectedRigOperator()
                this.loading = false
            })
        } catch (error) {
            this.loading = false
        }
    }
}