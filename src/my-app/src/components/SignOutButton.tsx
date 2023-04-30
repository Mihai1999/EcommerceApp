import { useMsal } from "@azure/msal-react"


const SignOutButton = () => {
    const { instance } = useMsal();

    const logout = (type: string = "popup") => {
        if (type === "popup") {
            instance.logoutPopup({
                postLogoutRedirectUri: "http://localhost:3000/",
            })
        }
    }

    return <button onClick={() => logout()}>
        Sign out
    </button>
}

export default SignOutButton;