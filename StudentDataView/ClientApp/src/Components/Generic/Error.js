import React from 'react'
import { Typography } from "@material-ui/core";

import Record from './Record'

export default function ErrorMsg(props) {
    return (
        <Record>
            <Typography
                variant="h5"
                color="error"
            >
                {props.message}
            </Typography>
        </Record>
    );
}
