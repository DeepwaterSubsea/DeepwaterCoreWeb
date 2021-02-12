import React from "react";
import { Button, Card, Image } from "semantic-ui-react";
import LoadingComponent from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";

export default function RigDetails() {
  const { rigStore } = useStore();
  const { selectedRig: rig, openForm, cancelSelectedRig } = rigStore;

  if (!rig) return <LoadingComponent content="Loading app..." />;

  return (
    <Card fluid>
      <Image src={`/assets/rigImages/${rig.name}.jpg`} wrapped ui={false} />
      <Card.Content>
        <Card.Header>{rig.name}</Card.Header>
        <Card.Meta>
          <span>Date</span>
        </Card.Meta>
        <Card.Description>Description</Card.Description>
      </Card.Content>
      <Card.Content extra>
        <Button.Group widths={2}>
          <Button
            onClick={() => openForm(rig.id)}
            basic
            color="blue"
            content="Edit"
          />
          <Button
            onClick={() => cancelSelectedRig()}
            basic
            color="grey"
            content="Cancel"
          />
        </Button.Group>
      </Card.Content>
    </Card>
  );
}
