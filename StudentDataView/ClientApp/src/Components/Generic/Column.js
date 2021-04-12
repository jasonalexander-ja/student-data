import React from 'react'
import TextField from '@material-ui/core/TextField';

export default function Column(props)
{
    return (
        <TextField 
            disabled 
            variant="outlined"
            label={props.Name} 
            value={props.Value} 
        />
    );
} 
