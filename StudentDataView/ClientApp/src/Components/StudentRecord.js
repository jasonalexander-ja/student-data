import React from 'react';
import Button from '@material-ui/core/Button';
import TextField from '@material-ui/core/TextField';

import Record from './Generic/Record.js'
import Column  from './Generic/Column.js';
import ContactDetails from './ContactDetails.js'
import ColumnGroup from './Generic/ColumnGroup.js'

import { baseURL, addPointsURI, parseBool, parseDate } from "../Helper.js"

export default class StudentRecord extends React.Component {
    constructor(props) {
        super(props)
        this.state = {
            student: props.data,
            showMore: true,
            error: false,
            errorText: ""
        };
    }

    toggleShow() {
        this.setState({
            showMore: !this.state.showMore
        });
    }

    async AddPoint() {
        const studentId = this.state.student.sourceId;
        let updatedStudent = await fetch(`${baseURL}${addPointsURI}/${studentId}`)
            .then(res => res.json())
            .catch(() => 
                this.setState({
                    error: true,
                    errorText: "Couldn't update the points for this student."
                }));
        if(updatedStudent) {
            this.setState({
                error: false,
                errorText: "",
                student: updatedStudent
            });
        }
    }

    render() {
        const student = this.state.student;
        const showMore = this.state.showMore;
        const errorText = this.state.errorText;
        const studentId = student.sourceId;

        return (
            <Record>
                <div>
                    <Column
                        Name="Name"
                        Value={`${student.firstName} ${student.lastName}`}
                    />
                    <Column
                        Name="Gender"
                        Value={student.gender}
                    />
                    <Column
                        Name="Year"
                        Value={student.yearCode}
                    />
                    <Column
                        Name="ULN"
                        Value={student.uln}
                    />
                </div>
                <div hidden={showMore}>
                    <ColumnGroup
                        recordId={studentId}
                        title="Address"
                        names={["UPN", 
                            "Year Group Id", 
                            "Date of Birth", 
                            "Has Free Meal", 
                            "Free Meal Review Date", 
                            "Service Child", 
                            "Looked After", 
                            "Ever in Care?", 
                            "Enrollment Status",
                            "Start Date",
                            "End Date"
                        ]}
                        values={[
                            student.upn,
                            student.yearGroupSourceId,
                            parseDate(student.dob),
                            parseDate(student.fsmReviewDate),
                            parseBool(student.serviceChild),
                            student.everInCare,
                            student.enrolmentStatus,
                            parseDate(student.startDate),
                            parseDate(student.endDate)
                        ]}
                    />
                    <ColumnGroup
                        recordId={studentId}
                        title="Address"
                        names={["Address Line 1", "Address Line 2", "Town/City", "County", "Country", "Postcode"]}
                        values={[
                            student.addressLine1,
                            student.addressLine2,
                            student.townCity,
                            student.county,
                            student.country,
                            student.postcode
                        ]}
                    />
                    <ColumnGroup
                        recordId={studentId}
                        title="Languages"
                        names={["Home Langauge", "First Language", "Proficiency in English", "Is EAL?"]}
                        values={[
                            student.homeLanguageName,
                            student.firstLanguageName,
                            student.proficiencyInEnglishName,
                            parseBool(student.isEal)
                        ]}
                    />
                    <ColumnGroup
                        recordId={studentId}
                        names={["Nationality", "Country of Birth", "NHS Number", "Is Pregnant?", "Has Emergency Consent?"]}
                        values={[
                            student.nationalities,
                            student.countryOfBirth,
                            student.nhsNumber,
                            student.isPregnant,
                            student.hasEmergencyConsent
                        ]}
                        title="Other"
                    />
                </div>
                <div hidden={showMore}>
                    <h3>Contacts</h3>
                    <>
                    {
                        // Only load the contacts if the user has expanded the student record 
                        showMore ? "" : <ContactDetails studentId={student.sourceId} />
                    }
                    </>
                </div>
                <Button onClick={() => this.toggleShow()}>Show {showMore ? "More" : "Less"}</Button>
                <Button color="secondary" onClick={() => this.AddPoint()}>Add Point</Button>
                <TextField
                    disabled
                    variant="standard"
                    value={errorText ? errorText : `Points: ${student.points}`}
                />
            </Record>
        );
    }
}
