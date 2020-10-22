<template>
  <div>
    <page-header />
    
    <div class="mt-8 max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
      <div class="mt-5 grid grid-cols-1 gap-5 sm:grid-cols-1 lg:grid-cols-8">
         <!-- categories table -->
        <div class="col-span-5"> 
          <div class="flex justify-between mb-2">
            <h2 class="text-lg leading-6 font-medium text-cool-gray-900">Categories</h2>
            <span class="relative z-0 inline-flex shadow-sm rounded-md">
              <button type="button"
                class="-ml-px relative inline-flex items-center px-4 py-2 border border-cool-gray-300 text-sm leading-5 font-medium text-cool-gray-700 bg-white hover:text-cool-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 active:bg-cool-gray-100 active:text-cool-gray-700 transition ease-in-out duration-150">
                Export
              </button>
            </span>
          </div>
          <Categories />
        </div>

         <!-- add new category form -->
         <div class="col-span-3"> 
           <div class="shadow sm:rounded-lg overflow-hidden">
            <div class="px-6 py-3 bg-gray-50 text-left text-xs leading-4 font-medium text-gray-500 uppercase tracking-wider border-b border-gray-300">
              Create a new category
            </div>
            <div class="bg-white w-full px-6 py-6">
              <form>
                <!-- category title -->
                <div>
                  <label for="email" class="block text-sm font-medium leading-5 text-gray-700">
                    Title
                  </label>
                  <div class="mt-1 rounded-md shadow-sm">
                    <input 
                      id="title" 
                      type="text" 
                      class="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md placeholder-gray-400 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 transition duration-150 ease-in-out sm:text-sm sm:leading-5"
                    >
                  </div>
                </div>

                <!-- category description -->
                <div class="mt-6">
                  <label for="description" class="block text-sm font-medium leading-5 text-gray-700">
                    Description
                  </label>
                  <div class="mt-1 rounded-md shadow-sm">
                    <textarea 
                      id="description" 
                      rows="6"
                      type="text" 
                      class="appearance-none block w-full px-3 py-2 border border-gray-300 rounded-md placeholder-gray-400 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 transition duration-150 ease-in-out sm:text-sm sm:leading-5"
                    >
                    </textarea>
                  </div>
                </div>

                <!-- ctegory image -->
                <div class="mt-6">
                  <croppa 
                    v-model="croppa" 
                    :width="340"
                    placeholder="choose an image"
                    :placeholder-font-size="14"
                    accept=".png, .jpg, image/jpeg, .JPG, .PNG, .JPEG"
                    :file-size-limit="1024000"
                    @file-type-mismatch="onFileTypeMismatch"
                    @file-size-exceed="onFileSizeExceed"
                  >
                  </croppa>
                </div>

                <div class="mt-6">
                  <span class="block w-full rounded-md shadow-sm">
                    <button 
                      type="submit" 
                      class="w-full flex justify-center py-2 px-4 border border-transparent text-sm font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-500 focus:outline-none focus:border-indigo-700 focus:shadow-outline-indigo active:bg-indigo-700 transition duration-150 ease-in-out"
                    >
                      Create Category
                    </button>
                  </span>
                </div>
              </form>
            </div>
           </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
  import Categories from '@/components/tables/categories/categories'
  export default {
    components: {
      Categories
    },
    methods: {
      onFileTypeMismatch (file) {
       alert('Invalid file type. Please choose a jpeg or png file.')
     },
     onFileSizeExceed (file) {
       alert('File size exceeds. Please choose a file smaller than 100kb.')
     }
    }
  }

</script>

<style>
  .croppa-container {
    background-color: transparent;
    border: 1px solid #e2e8f0;
    border-radius: 0.375rem;
    box-shadow: 0 1px 2px 0 rgba(0, 0, 0, 0.05);
  }
 
</style>
