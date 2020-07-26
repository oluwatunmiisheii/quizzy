<template>
  <div>
    <div class="pb-6">
      <h4 class="text-xl">Login</h4>
      <p class="text-base text-gray-700">Fill in your credentials to continue</p>
    </div>
    <form class="w-full">
      <div class="flex flex-wrap -mx-3 mb-6">
        <!-- email/username field -->
        <div class="w-full px-3 mb-6">
          <label class="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2" for="grid-full-name">Email/Username</label>
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

      <div class="flex flex-wrap -mx-3 mb-6">
        <!-- password field -->
        <div class="w-full px-3 mb-6">
          <label class="block uppercase tracking-wide text-gray-700 text-xs font-bold mb-2" for="grid-password">Password</label>
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
      <div class="flex items-center justify-between">
        <button
          class="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline"
          type="button"
        >
          Sign In
        </button>
        <a class="inline-block align-baseline font-bold text-sm text-blue-500 hover:text-blue-800" href="#">
          Forgot Password?
        </a>
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
  }
}
</script>