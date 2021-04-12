import React from 'react'

import {  
    TextField, 
    Select, 
    MenuItem,
    Typography, 
    Grid
} from "@material-ui/core";

export default function Search(props) {

    return (
        <div>
            <Grid
                container
            >
                <Select
                    autoWidth={false}
                    variant="outlined"
                    value={props.searchBy}
                    onChange={(field) => { 
                        props.FilterStudents(field.target.value, props.serachString);
                    }}
                >
                    <MenuItem value={"name"}>Name</MenuItem>
                    <MenuItem value={"year"}>Year</MenuItem>
                </Select>
                <TextField 
                    variant="outlined" 
                    label="Filter"
                    onChange={(field) => { 
                        props.FilterStudents(props.searchBy, field.target.value)
                    }}
                />
                <Typography variant="h3">Students Data View</Typography>
            </Grid>
            <br />
        </div>
    );
}
