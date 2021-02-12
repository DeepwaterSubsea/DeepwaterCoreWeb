import React from "react";
import { Button, Header, Icon, Image, Segment, Table } from "semantic-ui-react";
import { RigOperator } from "../../../app/models/rigOperator";

interface Props {
  rigOperators: RigOperator[];
  selectRigOperator: (id: string) => void;
}

export default function RigOperatorTable({
  rigOperators,
  selectRigOperator,
}: Props) {
  return (
    <Segment clearing>
      <Table celled padded selectable>
        <Table.Header>
          <Table.Row>
            <Table.HeaderCell>Operators</Table.HeaderCell>
            <Table.HeaderCell>Actions</Table.HeaderCell>
          </Table.Row>
        </Table.Header>
        <Table.Body>
          {rigOperators.map((rigOperator) => (
            <Table.Row key={rigOperator.id}>
              <Table.Cell>
                <Header as="h4" image>
                  <Image
                    src={`/assets/rigOperatorImages/${rigOperator.name}.jpg`}
                    rounded
                    size="mini"
                  />
                  <Header.Content>
                    {rigOperator.name}
                  </Header.Content>
                </Header>
              </Table.Cell>
              <Table.Cell>
                <Button.Group widths={2}>
                  <Button
                    onClick={() => selectRigOperator(rigOperator.id)}
                    floated="left"
                    content="View"
                    color="blue"
                  />
                </Button.Group>
              </Table.Cell>
            </Table.Row>
          ))}
          <Button floated="left" icon labelPosition="left" primary size="small">
            <Icon name="user" /> Add Operator
          </Button>
        </Table.Body>
      </Table>
    </Segment>
  );
}
