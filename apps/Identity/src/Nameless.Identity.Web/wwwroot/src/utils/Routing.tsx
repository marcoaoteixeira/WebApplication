import React from "react";
import {
  BrowserRouter,
  Routes,
  Route
} from "react-router-dom";

import Main from "../containers/layouts/Main";
import Home from "../pages/Home";

import Blank from "../containers/layouts/Blank";
import SignIn from "../pages/Auth/SignIn";

export default class Routing extends React.Component {
  render(): React.ReactNode {
      return (
        <BrowserRouter>
          <Routes>
            <Route path="/" element={<Main />}>
              <Route index element={<Home />} />
            </Route>

            <Route path="/auth" element={<Blank />}>
              <Route index element={<SignIn />} />
            </Route>
          </Routes>
        </BrowserRouter>
      );
  }
}