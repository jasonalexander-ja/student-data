import React from 'react'
import Column  from './Column.js';

function makeLine(names, values, source) {
    return names.map((colName, iter) => (
        <Column 
            Name={colName} 
            key={`${colName}-${iter}-${source}`} 
            Value={`${values[iter] ? values[iter] : "-"}`} 
        />
    ));
}

export default function ColumnGroup(props) {
    const names = props.names;
    const values = props.values;
    const title = (<h3>{props.title}</h3>);
    let lines = [];
    // Generate the lines for each group 
    for(let i = 0; i < Math.ceil(names.length / 4); i++) {
        let startPos = i * 4;
        let nameLine = names.slice(startPos, startPos + 4);
        let valueLine = values.slice(startPos, startPos + 4);
        let line = makeLine(nameLine, valueLine, props.recordId);
        lines.push(
            <div
                key={`${props.title}-${i}-${props.recordId}`}
            >
                {i === 0 ? title : (<br />) }
                {line}
            </div>
        );
    }
    return (
        <>
            {lines}
        </>
    );
}
