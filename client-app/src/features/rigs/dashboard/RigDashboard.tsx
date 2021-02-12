import { observer } from "mobx-react-lite";
import React, { useEffect } from "react";
import { Grid } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";
import RigDetails from "../details/RigDetails";
import RigForm from "../form/RigForm";
import RigList from "./RigList";

export default observer(function RigDashboard() {
  const { rigStore } = useStore();
  const { selectedRig, editMode } = rigStore;

  useEffect(() => {
    rigStore.loadRigs();
  }, [rigStore]);

  if (rigStore.loadingInitial)
    return <LoadingComponent content="Loading app" />;

  return (
    <Grid>
      <Grid.Column width={10}>
        <RigList />
      </Grid.Column>
      <Grid.Column width={6}>
        {selectedRig && !editMode && <RigDetails />}
        {editMode && <RigForm />}
      </Grid.Column>
    </Grid>
  );
});
