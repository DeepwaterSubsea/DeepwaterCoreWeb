import { makeAutoObservable } from "mobx";

export default class WellStore {

    constructor() {
        makeAutoObservable(this)
    }

    loadWells = async () => {
    }
}