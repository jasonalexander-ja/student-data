import React from 'react'
import { 
    Select, 
    MenuItem 
} from "@material-ui/core";

import Column from "./Generic/Column.js"

import {baseURL, parseBool, checkString, contactsURI} from "..\\Helper.js"

export default class ContactDetails extends React.Component {
    constructor(props) {
        super(props)
        this.state = {
            contacts: [],
            contactSelected: 0
        };
        this.GetContacts();
    }

    async GetContacts() {
        let contacts = await fetch(`${baseURL}${contactsURI}/${this.props.studentId}`)
            .then(res => res.json());
        this.setState({ contacts: contacts });
    }

    render() {
        const state = this.state;
        const contactIndex = state.contactSelected;
        const contact = state.contacts[contactIndex];
        if(!contact) {
            return (
                <h4>No linked contacts</h4>
            );
        }
        let contactOptions = state.contacts.map((contact, iter) => 
            (
                <MenuItem 
                    key={iter}
                    value={iter}
                >
                    {`${checkString(contact.Title)} ${checkString(contact.firstName)} ${checkString(contact.lastName)}`}
                </MenuItem>
            )
        );

        return (
            <div>
                <Select
                    autoWidth={false}
                    variant="outlined"
                    onChange={(field) => 
                        this.setState({ contactSelected: field.target.value 
                    })}
                    value={contactIndex}
                >
                    {contactOptions}
                </Select>
                <Column 
                    Name="Relationship"
                    Value={contact.relationship}
                />
                <Column 
                    Name="Is Next of Kin"
                    Value={parseBool(contact.nextOfKin)}
                />
                <Column 
                    Name="Description"
                    Value={contact.description}
                />
            </div>
        );
    }
} 
