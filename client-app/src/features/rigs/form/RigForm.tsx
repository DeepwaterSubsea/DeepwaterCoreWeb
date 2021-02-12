import { observer } from "mobx-react-lite";
import React, { ChangeEvent, useState } from "react";
import { Button, Form, Label, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";

export default observer(function RigForm() {
  const { rigStore } = useStore();

  const { selectedRig, closeForm, createRig, updateRig, loading } = rigStore;

  const initialState = selectedRig ?? {
    id: "",
    name: "",
    rigPrefix: "",
    shipBSEEId: "",
    shipId: "",
    shipMMSI: "",
    shipIMO: "",
    contractor: "",
    contractorId: "",
  };

  const [rig, setOperator] = useState(initialState);

  function handleSubmit() {
    rig.id ? updateRig(rig) : createRig(rig);
  }

  function handleInputChange(
    event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) {
    const { name, value } = event.target;
    setOperator({ ...rig, [name]: value });
  }

  return (
    <Segment clearing>
      <Form onSubmit={handleSubmit} autoComplete="off">
        <Label>Rig Name</Label>
        <Form.Input
          placeholder="Rig Name"
          value={rig.name}
          name="name"
          onChange={handleInputChange}
        />
        <Form.Input
          placeholder="Rig Prefix"
          value={rig.rigPrefix}
          name="rigPrefix"
        />
        <Form.Input
          placeholder="Ship BSEE Id"
          value={rig.shipBSEEId}
          name="shipBSEEId"
        />
        <Form.Input placeholder="Ship Id" value={rig.shipId} name="shipId" />
        <Form.Input
          placeholder="Ship MMSI"
          value={rig.shipMMSI}
          name="shipMMSI"
        />
        <Form.Input placeholder="Ship IMO" value={rig.shipIMO} name="shipIMO" />
        <Form.Input
          placeholder="Ship Contractor"
          value={rig.contractor.name}
          name="contractor"
        />
        <Button
          loading={loading}
          floated="right"
          positive
          type="submit"
          content="Submit"
        />
        <Button
          onClick={closeForm}
          floated="right"
          type="button"
          content="Cancel"
        />
      </Form>
    </Segment>
  );
});
