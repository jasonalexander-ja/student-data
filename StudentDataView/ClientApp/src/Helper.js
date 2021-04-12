export const baseURL = ""; // For debugging pruposes, so the front end can be used with any api source 
export const studentsBaseURI = "/api/Students";
export const addPointsURI = "/api/Students/AddPoint";
export const contactsURI = "/api/Contacts";


export function checkString(string) {
    return string ? string : "";
}

export function parseBool(bool) {
    return bool ? "Yes" : "No"
}

export function parseDate(date) {
    if(!date || date === "0001-01-01T00:00:00")
        return "";
    return `${new Date(date).getDate()}/${new Date(date).getMonth() + 1}/${new Date(date).getFullYear()}`
}

const exportObj = { baseURL, studentsBaseURI, addPointsURI, contactsURI, parseBool, parseDate, checkString }

export default exportObj;
