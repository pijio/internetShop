import React from 'react';
import useAuth from "../../hooks/useAuth/useAuth";
import { Redirect } from 'react-router-dom';
import {useSelector} from "react-redux";

const AuthorizedComponent = Component => props => {
    const { isAuth } = useSelector(({auth}) => auth.isAuthed)
    if( isAuth )
        return <Component {...props}/>;
    return <Redirect to={'/auth'}/>
};

export default AuthorizedComponent;