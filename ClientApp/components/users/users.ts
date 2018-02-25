import Vue from 'vue';
import { Component } from 'vue-property-decorator';

interface Users {
    id: number;
    name: string;
    mailAddress: string;
}

@Component
export default class UserComponent extends Vue {
    users: Users[] = [];
    showErrorAlert: boolean = false;
    errorMsg: string = "";

    // form data
    userName: string = "";
    mailAddress: string ="";

    mounted() {
        fetch('api/User/AllUsers')
            .then(response => response.json() as Promise<Users[]>)
            .then(data => {
                this.users = data;
            });
    }

    addAction() {

        const formElem: HTMLFormElement =<HTMLFormElement>document.getElementById("addForm");

        fetch('api/User/AddUser', {
            method: 'POST',
            body: new FormData(formElem)
          })
          .then(response => {
            if (!response.ok) {
                this.errorMsg = "Add User Error."
                this.showErrorAlert = true;
            }
          });
    }

    editAction() {
        
    }

    deleteAction() {

    }
}
