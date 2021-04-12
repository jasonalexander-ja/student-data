import React from 'react';
import reactDom from 'react-dom';

import Search from '.\\Components\\Search.js';
import StudentList from '.\\Components\\StudentsList.js';
import './index.css';

import { baseURL, studentsBaseURI } from ".\\Helper.js";

class App extends React.Component {
    constructor(props) {
        super(props)
        this.state = {
            loaded: false,
            studentsURI: studentsBaseURI,
            students: [],
            searchBy: "name",
            serachString: ""
        }
    }

    async GetStudents() {
        const state = this.state;
        let newStudents = await fetch(baseURL + state.studentsURI)
            .then(res => res.json());
        this.setState({
            loaded: true,
            students: newStudents
        });
    }

    FilterStudents(filterBy, filterString) {
        const state = this.state;
        if(!filterString && state.studentsURI !== studentsBaseURI) {
            this.setState({ 
                loaded: false,
                studentsURI: studentsBaseURI,
                serachString: filterString,
                searchBy: filterBy,
            });
            return;
        }
        if(!filterString) {
            this.setState({
                studentsURI: studentsBaseURI,
                serachString: filterString,
                searchBy: filterBy,
            });
            return;
        }
        this.setState({
            loaded: false,
            studentsURI: `${studentsBaseURI}?${filterBy}=${filterString}`,
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
                />
            </div>
        );
    }
}

reactDom.render(
    <App />,
    document.getElementById("root")
);
