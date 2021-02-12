import { observer } from "mobx-react-lite";
import React, { SyntheticEvent, useState } from "react";
import { Button, Icon, Item, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";

export default observer(function RigOperatorList() {
  const { rigOperatorStore } = useStore();
  const { deleteRigOperator, rigOperatorsByName, loading } = rigOperatorStore;

  const [target, setTarget] = useState("");

  function handleRigOperatorDelete(
    event: SyntheticEvent<HTMLButtonElement>,
    id: string
  ) {
    setTarget(event.currentTarget.name);
    deleteRigOperator(id);
  }

  return (
    <Segment clearing>
      <Button
        onClick={() => rigOperatorStore.openForm()}
        floated="left"
        icon
        labelPosition="left"
        primary
        size="small"
      >
        <Icon name="user" /> Add Operator
      </Button>
      <Item.Group divided>
        {rigOperatorsByName.map((rigOperator) => (
          <Item key={rigOperator.id}>
            <Item.Content>
              <Item.Image
                src={`/assets/rigOperatorImages/${rigOperator.name}.jpg`}
                rounded
                size="medium"
              />
              <Item.Extra>
                <Button
                  onClick={() =>
                    rigOperatorStore.selectRigOperator(rigOperator.id)
                  }
                  floated="right"
                  content="View"
                  color="blue"
                />
                <Button
                  name={rigOperator.id}
                  loading={loading && target === rigOperator.id}
                  onClick={(event) =>
                    handleRigOperatorDelete(event, rigOperator.id)
                  }
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
