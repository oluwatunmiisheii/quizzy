<template>
  <div>
    <template>
      <SignInForm />
    </template>
  </div>
</template>

<script>
import SignInForm from '@/components/Forms/SignInForm'
import { mapState } from 'vuex'
export default {
  components: {
    SignInForm,
    SuccessCard
  },
  data() {
    return {
      
    }
  }
}
</script>