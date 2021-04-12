import React from 'react'
import Column  from './Column.js';

function makeGroup(names, values, source) {
    return names.map((colName, iter) => (
        <Column 
            Name={colName} 
            key={`${colName}-${iter}-${source}`} 
            Value={`${values[iter] ? values[iter] : "(Blank)"}`} 
        />
    ));
}

export default function ColumnGroup(props) {
    const names = props.names;
    const values = props.values;
    const title = (<h3>{props.title}</h3>);
    let groups = [];
    for(let i = 0; i < Math.ceil(names.length / 4); i++) {
        let startPos = i* 4;
        let nameGroup = names.slice(startPos, startPos + 4);
        let valueGroup = values.slice(startPos, startPos + 4);
        let group = makeGroup(nameGroup, valueGroup, props.source);
        groups.push(
            <div key={`${props.title}-${i}-${props.source}`}>
                {i === 0 ? title : (<br />) }
                {group}
            </div>
        );
    }
    return (
        <>
        {groups}
        </>
    );
}
