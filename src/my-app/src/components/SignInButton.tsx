import React from "react";
import { useMsal } from "@azure/msal-react";


/**
 * Renders a button which, when selected, will open a popup for login
 */
export const SignInButton = () => {
    const { instance } = useMsal();

    const handleLogin = (loginType: string = "popup") => {
        if (loginType === "popup") {
            instance.loginPopup().catch(e => {
                console.log(e);
            });
        }
    }
    return (
        <button onClick={() => handleLogin("popup")}>Sign in using Popup</button>
    );
}