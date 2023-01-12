import React from 'react';
import { Redirect } from 'react-router-dom';
import {useSelector} from "react-redux";

const AuthorizedComponent = Component => props => {
    const { isAuth } = useSelector(({auth}) => auth)
    if( isAuth )
        return <Component {...props}/>;
    return <Redirect to={'/auth'}/>
};

export default AuthorizedComponent;