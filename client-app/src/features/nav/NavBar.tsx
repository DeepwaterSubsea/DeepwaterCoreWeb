import React from "react";
import { NavLink } from "react-router-dom";
import { Button, Container, Menu } from "semantic-ui-react";
import { useStore } from "../../app/stores/store";

export default function NavBar() {
  return (
    <Menu fixed="top" inverted>
      <Container>
        <Menu.Item as={NavLink} to="/" exact header>
          <img src="/assets/logo.png" alt="logo" />
        </Menu.Item>
        <Menu.Item as={NavLink} to="/rigOperators" name="Operators" />
        <Menu.Item as={NavLink} to="/rigContractors" name="Contractors" />
        <Menu.Item as={NavLink} to="/rigs" name="Rigs" />
        <Menu.Item as={NavLink} to="/wells" name="Wells" />
        <Menu.Item as={NavLink} to="/rigWellOperatorRecords" name="Records" />
        <Menu.Item>
          <Button
            as={NavLink}
            to="/createRigOperator"
            positive
            content="Create Rig Operator"
          />
        </Menu.Item>
      </Container>
    </Menu>
  );
}
