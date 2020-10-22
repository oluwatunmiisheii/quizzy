<template>
  <div>
    <template v-if="activeTab === 'form'">
      <SignUpForm @spinForm="activeTab = ''" />
    </template>
    <template v-else>
      <SuccessCard>
        <template slot="title">Registration Successful</template>
        <template slot="subTitle">Lorem ipsum dolor, sit amet consectetur adipisicing elit sit amet consectetur adipisicing elit</template>
        <template slot="actionButton">
          <button 
            @click.prevent="showAuthModal('Sign In')"
            type="button" 
            class="inline-flex mt-4 justify-center w-full rounded-md border border-transparent px-4 py-2 bg-indigo-600 text-base leading-6 font-medium text-white shadow-sm hover:bg-indigo-500 focus:outline-none focus:border-indigo-700 focus:shadow-outline-indigo transition ease-in-out duration-150 sm:text-sm sm:leading-5"
          >
            Login
          </button>
        </template>
      </SuccessCard>
    </template>
  </div>
</template>

<script>
import SignUpForm from '@/components/Forms/SignUpForm'
import SuccessCard from '@/components/UI/SuccessCard'
import { mapState } from 'vuex'
export default {
  components: {
    SignUpForm,
    SuccessCard
  },
  data() {
    return {
      activeTab: 'form'
    }
  },
  methods: {
    showAuthModal(type) {
      this.$store.dispatch('auth/getAuthFormState', type).then(() => {
        this.$modal.show('auth')
      })
    },
  },
}
</script>