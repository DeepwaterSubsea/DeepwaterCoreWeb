import React from "react";
import { Button, Card, Image } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";

export default function RigOperatorDetails() {
  const { rigOperatorStore } = useStore();
  const {
    selectedRigOperator: rigOperator,
    openForm,
    cancelSelectedRigOperator,
  } = rigOperatorStore;

  if (!rigOperator) return <LoadingComponent content="Loading app..." />;

  return (
    <Card fluid>
      <Image
        src={`/assets/rigOperatorImages/${rigOperator.name}.jpg`}
        wrapped
        ui={false}
      />
      <Card.Content>
        <Card.Header>{rigOperator.name}</Card.Header>
        <Card.Meta>
          <span>Date</span>
        </Card.Meta>
        <Card.Description>Description</Card.Description>
      </Card.Content>
      <Card.Content extra>
        <Button.Group widths={2}>
          <Button
            onClick={() => openForm(rigOperator.id)}
            basic
            color="blue"
            content="Edit"
          />
          <Button
            onClick={() => cancelSelectedRigOperator()}
            basic
            color="grey"
            content="Cancel"
          />
        </Button.Group>
      </Card.Content>
    </Card>
  );
}
