import { makeAutoObservable } from "mobx";

export default class RigContractorStore {

    constructor() {
        makeAutoObservable(this)
    }

    loadRigContrators = async () => {
    }
}