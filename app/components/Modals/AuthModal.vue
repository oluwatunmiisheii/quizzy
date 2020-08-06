<template>
  <div id="auth-modal">
    <modal name="auth" :clickToClose="false" :adaptive="true" :width="400" :height="300" :shiftY=0.5>
      <div slot="top-right">
        <button @click="$modal.hide('auth')">&times;</button>
      </div>
      <div class="p-4">
        <template v-if="formState === 'Sign Up'">
          <SignUpForm />
        </template>
        <template v-if="formState === 'Sign In'">
          <SignInForm />
        </template>
      </div>
    </modal>
  </div>
</template>

<script>
import SignUpForm from '@/components/Forms/SignUp'
import SignInForm from '@/components/Forms/SignIn'
import { mapState } from 'vuex'
export default {
  components: {
    SignInForm,
    SignUpForm
  },
  methods: {
    
  },
  computed: {
   ...mapState({
     formState: state => state.auth.formState,
   })
  },
  
}
</script>


