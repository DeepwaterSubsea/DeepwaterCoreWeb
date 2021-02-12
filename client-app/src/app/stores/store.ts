import { createContext, useContext } from "react";
import RigAssetStore from "./rigAssetStore";
import RigContractorStore from "./rigContractorStore";
import RigOEMStore from "./rigOEMStore";
import RigOperatorStore from "./rigOperatorStore";
import RigStore from "./rigStore";
import StatusInformationStore from "./statusInformationStore";
import WellStore from "./wellStore";


interface Store {
    rigAssetStore: RigAssetStore
    rigContractorStore: RigContractorStore
    rigOEMStore: RigOEMStore
    rigOperatorStore: RigOperatorStore
    rigStore: RigStore
    statusInformationStore: StatusInformationStore
    wellStore: WellStore
}

export const store: Store = {
    rigAssetStore: new RigAssetStore(),
    rigContractorStore: new RigContractorStore(),
    rigOEMStore: new RigOEMStore(),
    rigOperatorStore: new RigOperatorStore(),
    rigStore: new RigStore(),
    statusInformationStore: new StatusInformationStore(),
    wellStore: new WellStore()

}

export const StoreContext = createContext(store)

export function useStore() {
    return useContext(StoreContext)

}