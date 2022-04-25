import React from "react";
import { Outlet } from "react-router-dom";

export default class Main extends React.Component {
  render(): React.ReactNode {
    return (
      <div>
        <h1>Main</h1>
        <Outlet />
      </div>
    );
  }
}
