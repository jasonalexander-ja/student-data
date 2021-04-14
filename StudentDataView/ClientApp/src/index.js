import React from 'react';
import reactDom from 'react-dom';

import Search from './Components/Search.js';
import StudentList from './Components/StudentsList.js';
import './index.css';

import { baseURL, studentsBaseURI } from "./Helper.js";

class App extends React.Component {
    constructor(props) {
        super(props)
        this.state = {
            loaded: false,
            studentsURI: studentsBaseURI,
            students: [],
            searchBy: "name",
            serachString: "",
            error: false,
            errorMsg: ""
        }
    }

    async GetStudents() {
        const state = this.state;
        let newStudents = await fetch(baseURL + state.studentsURI)
            .then(res => res.json())
            .catch(() => {
                this.setState({
                    error: true,
                    errorMsg: "Couldn't load student data at this moment."
                });
            });
        this.setState({
            loaded: true,
            students: newStudents
        });
    }

    FilterStudents(filterBy, filterString) {
        const state = this.state;
        if(!filterString) {
            this.setState({
                // If query parameters already are blank, no need to reload 
                loaded: state.studentsURI === studentsBaseURI,
                studentsURI: studentsBaseURI,
                serachString: "",
                searchBy: filterBy,
            });
            return;
        }
        let filterStrEncoded = encodeURIComponent(filterString);
        this.setState({
            loaded: false,
            studentsURI: `${studentsBaseURI}?${filterBy}=${filterStrEncoded}`,
            searchBy: filterBy,
            serachString: filterString
        });
    }

    render() {
        const state = this.state;
        if(!state.loaded) {
            this.GetStudents();
        }
        return (
            <div id="main">
                <Search 
                    FilterStudents={this.FilterStudents.bind(this)} 
                    searchBy={state.searchBy}
                    serachString={state.serachString}
                />
                <StudentList 
                    students={state.students}
                    error={state.error}
                    errorMSg={state.errorMsg}
                />
            </div>
        );
    }
}

reactDom.render(
    <App />,
    document.getElementById("root")
);
