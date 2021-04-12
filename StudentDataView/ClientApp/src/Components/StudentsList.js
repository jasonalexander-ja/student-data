import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Grid from '@material-ui/core/Grid';

import StudentRecord from './StudentRecord.js'

const useStyles = makeStyles((theme) => ({
    root: {
        flexGrow: 1,
    },
}));

export default function StudentList(props) {
    const classes = useStyles();
    let studentsElements = props.students.map(student => (
        <StudentRecord 
            data={student} 
            key={student.sourceId} 
        />
    ));
    return (
        <div className={classes.root}>
            <Grid container spacing={3}>
                {studentsElements}
            </Grid>
        </div>
    );
}
