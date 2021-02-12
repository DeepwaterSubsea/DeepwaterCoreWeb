import { observer } from "mobx-react-lite";
import React, { useEffect } from "react";
import { Grid } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";
import RigOperatorDetails from "../details/RigOperatorDetails";
import RigOperatorForm from "../form/RigOperatorForm";
import RigOperatorList from "./RigOperatorList";

export default observer(function RigOperatorDashboard() {
  const { rigOperatorStore } = useStore();
  const { selectedRigOperator, editMode } = rigOperatorStore;

  useEffect(() => {
    rigOperatorStore.loadRigOperators();
  }, [rigOperatorStore]);

  if (rigOperatorStore.loadingInitial)
    return <LoadingComponent content="Loading app" />;

  return (
    <Grid>
      <Grid.Column width={10}>
        <RigOperatorList />
      </Grid.Column>
      <Grid.Column width={6}>
        {selectedRigOperator && !editMode && <RigOperatorDetails />}
        {editMode && <RigOperatorForm />}
      </Grid.Column>
    </Grid>
  );
});
