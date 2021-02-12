import { makeAutoObservable } from "mobx";

export default class RigAssetStore {

    constructor() {
        makeAutoObservable(this)
    }

    loadRigAssets = async () => {
    }
}