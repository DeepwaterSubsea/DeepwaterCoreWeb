import { observer } from "mobx-react-lite";
import React, { ChangeEvent, useState } from "react";
import { Button, Form, Segment } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";

export default observer(function RigOperatorForm() {
  const { rigOperatorStore } = useStore();

  const {
    selectedRigOperator,
    closeForm,
    createRigOperator,
    updateRigOperator,
    loading,
  } = rigOperatorStore;

  const initialState = selectedRigOperator ?? {
    id: "",
    name: "",
  };

  const [rigOperator, setOperator] = useState(initialState);

  function handleSubmit() {
    rigOperator.id
      ? updateRigOperator(rigOperator)
      : createRigOperator(rigOperator);
  }

  function handleInputChange(
    event: ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) {
    const { name, value } = event.target;
    setOperator({ ...rigOperator, [name]: value });
  }

  return (
    <Segment clearing>
      <Form onSubmit={handleSubmit} autoComplete="off">
        <Form.Input
          placeholder="Contact Name"
          value={rigOperator.name}
          name="name"
          onChange={handleInputChange}
        />
        <Form.Input placeholder="Contact Number" />
        <Form.Input placeholder="Contact Email" />
        {/* <Form.Input type="date" placeholder="Date" /> */}
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
