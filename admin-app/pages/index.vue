<template>
  <div class="min-h-screen bg-gray-100 flex">
    <div class="flex-1 flex flex-col justify-center py-12 px-4 sm:px-6 lg:flex-none lg:px-20 xl:px-24">
      <div class="mx-auto w-full max-w-sm lg:w-96">
        <div>
          <img class="h-12 w-auto" src="https://tailwindui.com/img/logos/workflow-mark-on-white.svg" alt="Workflow">
          <h2 class="mt-6 text-3xl leading-9 font-extrabold text-gray-900">
            Sign in to your account
          </h2>
        </div>

        <div class="mt-8 pt-6">
          <ValidationObserver v-slot="{ invalid, handleSubmit, reset}">
            <form class="space-y-6" @submit.prevent="handleSubmit(submit)" @reset.prevent="reset">
              <div>
                <label for="username" class="block text-sm font-medium leading-5 text-gray-700">
                  Username
                </label>
                <ValidationProvider rules="required|min:3" name="username" v-slot="{ errors }">
                  <div class="mt-1 rounded-md shadow-sm">
                    <input 
                      id="username" 
                      type="text"
                      vid="username"
                      v-model="user.username"
                      class="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md placeholder-gray-400 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 transition duration-150 ease-in-out sm:text-sm sm:leading-5"
                    >
                  </div>
                  <span class="text-sm text-red-600">{{ errors[0] }}</span>
                </ValidationProvider>
              </div>

              <div>
                <label for="password" class="block text-sm font-medium leading-5 text-gray-700">
                  Password
                </label>
                <ValidationProvider vid="password" rules="required|min:6" name="password" v-slot="{ errors }">
                  <div class="mt-1 rounded-md shadow-sm">
                    <input 
                      v-model="user.password"
                      id="password" 
                      vid="password"
                      type="password"  
                      class="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md placeholder-gray-400 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 transition duration-150 ease-in-out sm:text-sm sm:leading-5"
                    >
                  </div>
                  <span class="text-sm text-red-600">{{ errors[0] }}</span>
                </ValidationProvider>
              </div>

              <div>
                <span class="block w-full rounded-md shadow-sm">
                  <button 
                    type="submit" 
                    :disabled="invalid"
                    class="w-full flex justify-center py-2 px-4 border border-transparent text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-500 focus:outline-none focus:border-indigo-700 focus:shadow-outline-indigo active:bg-indigo-700 transition duration-150 ease-in-out"
                  >
                    Sign in
                  </button>
                </span>
              </div>
              <div class="flex items-center justify-center">
                <div class="text-sm leading-5">
                  <a 
                    href="#" 
                    class="font-medium text-indigo-600 hover:text-indigo-500 focus:outline-none focus:underline transition ease-in-out duration-150"
                  >
                    Forgot your password?
                  </a>
                </div>
              </div>
            </form>
          </ValidationObserver>
        </div>
      </div>
    </div>
    <div class="hidden lg:block relative w-0 flex-1">
      <img class="absolute inset-0 h-full w-full object-cover" src="https://images.pexels.com/photos/4260758/pexels-photo-4260758.jpeg?cs=srgb&dl=pexels-august-de-richelieu-4260758.jpg&fm=jpg" alt="">
    </div>
  </div>
</template>

<script>
export default {
  layout: 'auth',
  data() {
    return {
      user: {}
    }
  },
  methods: {
    submit() {
      console.log('here');
    }
  }
}
</script>

<style lang="">
  
</style>