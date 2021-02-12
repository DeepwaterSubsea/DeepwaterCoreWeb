import React from "react";
import { Button, Header, Icon, Image, Segment, Table } from "semantic-ui-react";
import { Rig } from "../../../app/models/rig";

interface Props {
  rigs: Rig[];
  selectRig: (id: string) => void;
}

export default function RigTable({ rigs, selectRig }: Props) {
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
          {rigs.map((rig) => (
            <Table.Row key={rig.id}>
              <Table.Cell>
                <Header as="h4" image>
                  <Image
                    src={`/assets/rigImages/${rig.name}.jpg`}
                    rounded
                    size="mini"
                  />
                  <Header.Content>{rig.name}</Header.Content>
                </Header>
              </Table.Cell>
              <Table.Cell>
                <Button.Group widths={2}>
                  <Button
                    onClick={() => selectRig(rig.id)}
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
