<template>
  <div>
   <page-header />
    <div class="mt-8 max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
      <div>
        <h2 class="text-lg leading-6 font-medium text-cool-gray-900">All Users</h2>
        <div class="mt-5">
          <Users />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
  import Users from '@/components/tables/users/users'
  export default {
    components: {
      Users
    }
  }

</script>

<style>

</style>
