import React from "react";
import useBodyClass from "../../effects/useBodyClass";
import Card from "react-bootstrap/Card";
import { Link } from "react-router-dom";
import { useTranslation } from "react-i18next";
import * as Yup from "yup";
import { useDispatch } from "react-redux";
import { useFormik } from "formik";

// resources
import application_logo from "../../assets/img/application_logo.png"

export default function SignIn() {
  const [T] = useTranslation("translation", {
    keyPrefix: "Auth.SignIn"
  });

  useBodyClass(["login-page"]);

  return (
    <div className="login-box">
      <Card className="card-outline card-primary">
        <Card.Header className="text-center">
          <Link to="/">
            <img src={application_logo} alt="`${process.env.REACT_APP_APPLICATION_NAME}`" />
          </Link>  
        </Card.Header>
        <Card.Body>
          <p className="login-box-msg">{T("Sign in to start your session")}</p>
        </Card.Body>
      </Card>
    </div>
  );
}