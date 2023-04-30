import { AuthProvider } from 'oidc-react';
import React from 'react';
import { Route, Routes } from 'react-router-dom';
import App from '../App';
import Home from '../views/Home/Home';
import * as msal from "@azure/msal-browser";
import { AccountInfo, PublicClientApplication } from '@azure/msal-browser';
import { AuthenticatedTemplate, MsalProvider } from '@azure/msal-react';


interface PrivateRoutesComponentProps {
}

const msalConfig = {
    auth: {
        clientId: 'd8447014-4d79-45eb-b492-9fdc1f61c609',
        authority: 'https://login.microsoftonline.com/12aa3fbc-79c9-440b-b823-b04539397e2b',
        //authority: 'https://login.microsoftonline.com/',
        redirectUri: 'http://localhost:3000/',
    }
};

const PrivateRoutes = (props: PrivateRoutesComponentProps) => {

    const msalInstance = new PublicClientApplication(msalConfig);
    return <MsalProvider instance={msalInstance}>
        <Routes>
            <Route path="/" element={<Home />} />

            <Route path="/app" element={<AuthenticatedTemplate><App /></AuthenticatedTemplate>} />
        </Routes>
    </MsalProvider>

}


export default PrivateRoutes;

