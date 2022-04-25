import React from "react";
import { Outlet } from "react-router-dom";
import useBodyClass from "../../effects/useBodyClass";

// styles
import "./Blank.css";

export default function Blank() {
  useBodyClass(["hold-transition"]);

  return (
    <Outlet />
  );
}
