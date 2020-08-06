<template>
  <div>
    <div class="pb-8">
      <h4 class="text-xl pb-1 font-bold  text-gray-900">Create an account</h4>
      <p class="text-base text-gray-700">Fill in the form below to get started</p>
    </div>
    <form class="w-full">
      <div class="flex flex-wrap -mx-3">
        <!-- full name field -->
        <div class="w-full px-3 mb-4">
          <label class="block text-sm font-medium leading-5 text-gray-700 mb-1" for="grid-full-name">Full Name</label>
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

        <!-- uername field -->
        <div class="w-full px-3 mb-4">
          <label 
            class="block text-sm font-medium leading-5 text-gray-700 mb-1"
            for="grid-user-name"
          >
            Username
          </label>
          <input
            @input="resetValidation('username')" 
            class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
            id="grid-user-name" 
            v-validate="'required|min:4'"
            data-vv-scope="register"
            name="username"
            data-vv-as="username"  
            type="text" 
            placeholder="Tunmii"
            v-model="regDetails.username"
          >
          <span v-show="errors.has('register.username')" class="text-red-500 text-xs italic">
            <!-- <em class="fas fa-info-circle mr-1"></em>  -->
            {{ errors.first('register.username') }}
          </span>
        </div>

        <!-- email field -->
        <div class="w-full px-3 mb-4">
          <label class="block text-sm font-medium leading-5 text-gray-700 mb-t" for="grid-email">Email</label>
          <input
            class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
            @input="resetValidation('email')" 
            data-vv-scope="register"
            v-validate="'required|email'"
            name="email"
            id="grid-email" 
            type="email" 
            placeholder="doe@email.com"
            v-model="regDetails.email"
          >
            <span v-show="errors.has('register.email')" class="text-red-500 text-xs italic">
            <!-- <em class="fas fa-info-circle mr-1"></em>  -->
            {{ errors.first('register.email') }}
          </span>
        </div>

        <!-- password field -->
        <div class="w-full px-3">
          <label class="block text-sm font-medium leading-5 text-gray-700 mb-1" for="grid-password">Password</label>
          <input
            class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 mb-3 leading-tight focus:outline-none focus:bg-white focus:border-gray-500"
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
      <div class="flex w-full mt-6">
        <button
          class="relative inline-flex text-center justify-center w-full items-center px-4 py-2 border border-transparent text-sm leading-5 font-medium rounded-md text-white bg-indigo-600 shadow-sm hover:bg-indigo-500 focus:outline-none focus:border-indigo-700 focus:shadow-outline-indigo active:bg-indigo-700 transition ease-in-out duration-150"
          type="button"
        >
          Sign Up
        </button>
      </div>

      <div class="flex w-full justify-center text-center mt-2">
        <p class="text-base text-gray-700">
          Already have an account?  
          <a 
            class="inline-block align-baseline font-bold text-sm text-indigo-800 hover:text-indigo-500" 
            href="#" 
            @click.prevent="showAuthModal('Sign In')"
          >
            Sign In
          </a>
        </p>
      </div>
    </form>
  </div>
</template>

<script>
export default {
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