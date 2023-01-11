import React from 'react';
import useAuth from "../../hooks/useAuth/useAuth";
import { Redirect } from 'react-router-dom';

const AuthorizedComponent = Component => props => {
    const { isAuth } = useAuth();
    if(isAuth)
        return <Component {...props}/>;
    return <Redirect to={'/auth'}/>
};

export default AuthorizedComponent;