import Vue from 'vue'
import { ValidationProvider, ValidationObserver } from 'vee-validate/dist/vee-validate.full';
import 'vue-croppa/dist/vue-croppa.css'
import Croppa from 'vue-croppa'


Vue.component('ValidationProvider', ValidationProvider);
Vue.component('ValidationObserver', ValidationObserver);
Vue.use(Croppa)  