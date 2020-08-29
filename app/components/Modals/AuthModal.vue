<template>
  <div id="auth-modal">
    <modal name="auth" :clickToClose="false" :adaptive="true" :width="450" :height="300" :shiftY=0.5>
      <div slot="top-right">
        <button @click="$modal.hide('auth')">&times;</button>
      </div>
      <div class="p-4">
        <template v-if="formState === 'Sign Up'">
          <SignUp />
        </template>
        <template v-if="formState === 'Sign In'">
          <SignInForm />
        </template>
      </div>
    </modal>
  </div>
</template>

<script>
import SignUp from '@/components/Auth/SignUp'
import SignInForm from '@/components/Forms/SignInForm'
import { mapState } from 'vuex'
export default {
  components: {
    SignUp,
    SignInForm
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


