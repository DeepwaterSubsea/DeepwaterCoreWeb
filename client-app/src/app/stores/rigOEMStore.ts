import { makeAutoObservable } from "mobx";

export default class RigOEMStore {

    constructor() {
        makeAutoObservable(this)
    }

    loadRigOEMs = async () => {
    }
}