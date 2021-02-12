import React from "react";
import "semantic-ui-css/semantic.min.css";
import { Container } from "semantic-ui-react";
import RigOperatorDashboard from "../../features/rigOperators/dashboard/RigOperatorDashboard";
import NavBar from "../../features/nav/NavBar";
import { observer } from "mobx-react-lite";
import { Route } from "react-router-dom";
import HomePoage from "../../features/home/HomePage";
import RigOperatorForm from "../../features/rigOperators/form/RigOperatorForm";
import RigDashboard from "../../features/rigs/dashboard/RigDashboard";
import RigForm from "../../features/rigs/form/RigForm";

const App = () => {
  return (
    <>
      <Route exact path="/" component={HomePoage} />
      <Route
        path={"/(.+)"}
        render={() => (
          <>
            <NavBar />
            <Container style={{ marginTop: "7em" }}>
              <Route exact path="/" component={HomePoage} />
              <Route path="/rigs" component={RigDashboard} />
              <Route path="/rig" component={RigForm} />
              <Route path="/rigOperators" component={RigOperatorDashboard} />
              <Route path="/createRigOperator" component={RigOperatorForm} />
            </Container>
          </>
        )}
      />
    </>
  );
};

export default observer(App);
