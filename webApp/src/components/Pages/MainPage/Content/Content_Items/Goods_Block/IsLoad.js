import logo from "./FirstPageForGoods/isloading.png";
import React from "react";
import './isLoad.css'

const IsLoad = () => {
    return (
        <>
            <div className="error404page">
                <div className="newcharacter404">
                    <div className="chair404"></div>
                    <div className="leftshoe404"></div>
                    <div className="rightshoe404"></div>
                    <div className="legs404"></div>
                    <div className="torso404">
                        <div className="body404"></div>
                        <div className="leftarm404"></div>
                        <div className="rightarm404"></div>
                        <div className="head404">
                            <div className="eyes404"></div>
                        </div>
                    </div>
                    <div className="laptop404"></div>
                </div>
            </div>
            <div className="preloader">
                <div className="preloader__row">
                    <div className="preloader__item"></div>
                    <div className="preloader__item"></div>
                </div>
            </div>
        </>
    )
}
export default IsLoad