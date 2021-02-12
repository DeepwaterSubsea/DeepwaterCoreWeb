import { observer } from "mobx-react-lite";
import React, { SyntheticEvent, useState } from "react";
import { Button, Icon, Item, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";

export default observer(function RigList() {
  const { rigStore } = useStore();
  const { deleteRig, rigsByName, loading } = rigStore;

  const [target, setTarget] = useState("");

  function handleRigDelete(
    event: SyntheticEvent<HTMLButtonElement>,
    id: string
  ) {
    setTarget(event.currentTarget.name);
    deleteRig(id);
  }

  return (
    <Segment clearing>
      <Button
        onClick={() => rigStore.openForm()}
        floated="left"
        icon
        labelPosition="left"
        primary
        size="small"
      >
        <Icon name="user" /> Add Rig
      </Button>
      <Item.Group divided>
        {rigsByName.map((rig) => (
          <Item key={rig.id}>
            <Item.Content>
              <Item.Image
                src={`/assets/rigImages/${rig.name}.jpg`}
                rounded
                size="medium"
              />
              <Item.Extra>
                <Button
                  onClick={() => rigStore.selectRig(rig.id)}
                  floated="right"
                  content="View"
                  color="blue"
                />
                <Button
                  name={rig.id}
                  loading={loading && target === rig.id}
                  onClick={(event) => handleRigDelete(event, rig.id)}
                  floated="right"
                  content="Delete"
                  color="red"
                />
              </Item.Extra>
            </Item.Content>
          </Item>
        ))}
      </Item.Group>
      <Button floated="left" icon labelPosition="left" primary size="small">
        <Icon name="user" /> Add Operator
      </Button>
    </Segment>
  );
});
