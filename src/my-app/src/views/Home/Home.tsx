import { useIsAuthenticated } from '@azure/msal-react';
import React from 'react';
import { SignInButton } from '../../components/SignInButton';
import SignOutButton from '../../components/SignOutButton';


interface HomeComponentProps {

}

const Home = (props: HomeComponentProps) => {
    const isAuthenticated = useIsAuthenticated()
    return <div><h1>
        Home
    </h1>
        {isAuthenticated ? "Signed In" : <SignInButton />}
        <br />
        {isAuthenticated && <SignOutButton />}
    </div>
}

export default Home