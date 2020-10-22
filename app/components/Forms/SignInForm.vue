<template>
  <div>
    <div class="pb-6">
      <h4 class="text-xl pb-1 font-bold  text-gray-900">Sign In</h4>
      <p class="text-base text-gray-700">Fill in your credentials to continue</p>
    </div>
    <div class="w-full pb-5">
      <AlertDanger> 
        <template slot="errorMessage">
          <h3 class="text-sm leading-5 font-medium text-red-800">Attention needed</h3>
          <div class="mt-2 text-sm leading-5 text-red-700">
            <p>Invalid Sign In Credentials</p>
          </div>
        </template>
      </AlertDanger>
    </div>
    <form class="w-full">
      <div class="flex flex-wrap -mx-3 mb-4">
        <!-- email/username field -->
        <div class="w-full px-3">
          <label class="block text-sm font-medium leading-5 text-gray-700 mb-1" for="grid-full-name">Email/Username</label>
          <input
            @input="resetValidation('fullname')" 
            v-model="regDetails.fullname"
            class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
            id="grid-full-name" 
            type="text" 
            v-validate="'required|min:4'"
            data-vv-scope="register"
            name="fullname"
            data-vv-as="full name"  
            placeholder="John Doe"
          >
          <span v-show="errors.has('register.fullname')" class="text-red-500 text-xs italic">
            <!-- <em class="fas fa-info-circle mr-1"></em>  -->
            {{ errors.first('register.fullname') }}
          </span>
        </div>
      </div>

      <div class="flex flex-wrap -mx-3">
        <!-- password field -->
        <div class="w-full px-3">
          <div class="flex justify-between items-center mb-1">
            <label class="block text-sm font-medium leading-5 text-gray-700" for="grid-password">Password</label>
            <a class="inline-block align-baseline font-bold text-sm text-indigo-600 hover:text-indigo-500" href="#">
              Forgot Password?
            </a>
          </div>
          <input
            class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
            id="grid-password" 
            @input="resetValidation('password')" 
            data-vv-scope="register"
            v-validate="'required|min:6'"
            name="password"
            type="password" 
            placeholder="******************"
            v-model="regDetails.password"
          >
          <span v-show="errors.has('register.password')" class="text-red-500 text-xs italic">
            <!-- <em class="fas fa-info-circle mr-1"></em>  -->
            {{ errors.first('register.password') }}
          </span>
        </div>
      </div>

      <!-- action button -->
      <div class="flex items-center justify-between mt-6">
        <button
          class="relative inline-flex text-center justify-center w-full items-center px-4 py-2 border border-transparent text-sm leading-5 font-medium rounded-md text-white bg-indigo-600 shadow-sm hover:bg-indigo-500 focus:outline-none focus:border-indigo-700 focus:shadow-outline-indigo active:bg-indigo-700 transition ease-in-out duration-150"
          type="button"
        >
          Sign In
        </button>
      </div>

       <div class="flex w-full justify-center text-center mt-2">
        <p>
          Dont have an account?  
          <a 
            class="inline-block align-baseline font-bold text-sm text-indigo-600 hover:text-indigo-500" 
            href="#" @click.prevent="showAuthModal('Sign Up')"
          >
            Sign Up
          </a>
        </p>
      </div>
    </form>
  </div>
</template>

<script>
import AlertDanger from '@/components/Alerts/AlertDanger'
export default {
  components: {
    AlertDanger
  },
  data() {
    return {
      regDetails: {
        fullname: '',
        username: '',
        password: '',
        email: ''
      }
    }
  },
  methods: {
    resetValidation(key) {
			let matcher = {
				scope: "register",
				name: key
			};
			this.$validator.reset(matcher);
    },
    showAuthModal(type) {
      this.$store.dispatch('auth/getAuthFormState', type).then(() => {
        this.$modal.show('auth')
      })
    }
  }
}
</script>