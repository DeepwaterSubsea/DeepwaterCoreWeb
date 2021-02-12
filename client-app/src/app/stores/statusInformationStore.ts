import { makeAutoObservable } from "mobx";

export default class StatusInformationStore {

    constructor() {
        makeAutoObservable(this)
    }

    loadStatusInformation = async () => {
    }
}