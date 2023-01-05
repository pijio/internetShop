import React, {useState, useEffect} from 'react'
import {YMaps, Map, Placemark, FullscreenControl} from "react-yandex-maps";
import './Maps.css'

const Maps = () => {
        const mapData = {
            center: [42.868728, 74.557860],
            zoom: 14,
        };

        const [coordinates, setCoord] = useState([])

        const loadData = async () => {
            // await fetch
            setCoord([[42.874662, 74.638519]])
        }

        useEffect(() => {
            loadData()
        }, [])

        return (
            <div className={'maps__div'}>
                <YMaps>
                    <Map width='50%'
                         height='500px'
                         defaultState={mapData}>
                        {coordinates.map(coordinate => <Placemark options={{
                            iconLayout: 'default#image',

                        }} geometry={coordinate}/>)}
                        <FullscreenControl options={{float: 'left'}}/>
                    </Map>
                </YMaps>
            </div>
        )
    };

export default Maps;