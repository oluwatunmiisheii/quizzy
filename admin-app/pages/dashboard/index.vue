<template>
  <div>
    <page-header />
    <div class="mt-8 max-w-6xl mx-auto px-4 sm:px-6 lg:px-8">
      <div>
        <h2 class="text-lg leading-6 font-medium text-cool-gray-900">Overview</h2>
        <div class="mt-5 grid grid-cols-1 gap-5 sm:grid-cols-2 lg:grid-cols-3">
          <!-- all users -->
          <AnalyticsCard :count="83" :heading="'Users'" :ctaText="'View all'">
            <svg class="h-6 w-6 
              text-white" fill="none" viewBox="0 0 24 24" stroke="currentColor">
              <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2"
                d="M12 4.354a4 4 0 110 5.292M15 21H3v-1a6 6 0 0112 0v1zm0 0h6v-1a6 6 0 00-9-5.197M13 7a4 4 0 11-8 0 4 4 0 018 0z" />
            </svg>
          </AnalyticsCard>

          <!-- categories -->
          <AnalyticsCard :count="5" :heading="'Categories'" :ctaText="'View all'">
            <svg class="h-6 w-6 
            text-white" fill="none" viewBox="0 0 24 24" stroke="currentColor">
              <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2"
                d="M12 4.354a4 4 0 110 5.292M15 21H3v-1a6 6 0 0112 0v1zm0 0h6v-1a6 6 0 00-9-5.197M13 7a4 4 0 11-8 0 4 4 0 018 0z" />
            </svg>
          </AnalyticsCard>

          <!-- categories -->
          <AnalyticsCard :count="3000" :heading="'Questions'" :ctaText="'View all'">
            <svg class="h-6 w-6 
            text-white" fill="none" viewBox="0 0 24 24" stroke="currentColor">
              <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2"
                d="M12 4.354a4 4 0 110 5.292M15 21H3v-1a6 6 0 0112 0v1zm0 0h6v-1a6 6 0 00-9-5.197M13 7a4 4 0 11-8 0 4 4 0 018 0z" />
            </svg>
          </AnalyticsCard>
        </div>
      </div>
      <div class="mt-5 grid grid-cols-1 gap-5 sm:grid-cols-1 lg:grid-cols-2">
        <!-- leaderboard table -->
        <div>
          <div class="flex justify-between mt-8">
            <h2 class="text-lg leading-6 font-medium text-cool-gray-900">LeaderBoard</h2>
            <span class="relative z-0 inline-flex shadow-sm rounded-md">
              <button type="button"
                class=" relative inline-flex items-center px-4 py-2 border border-cool-gray-300 text-sm leading-5 font-medium text-cool-gray-700 bg-white hover:text-cool-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 active:bg-cool-gray-100 active:text-cool-gray-700 transition ease-in-out duration-150">
                View all
              </button>
              <button type="button"
                class="-ml-px relative inline-flex items-center px-4 py-2 border border-cool-gray-300 text-sm leading-5 font-medium text-cool-gray-700 bg-white hover:text-cool-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 active:bg-cool-gray-100 active:text-cool-gray-700 transition ease-in-out duration-150">
                Export
              </button>
            </span>
          </div>
          <LeaderBoard />
        </div>

        <!-- recent users -->
        <div>
          <div class="flex justify-between mt-8">
            <h2 class="text-lg leading-6 font-medium text-cool-gray-900">Recent users</h2>
            <span class="relative z-0 inline-flex shadow-sm rounded-md">
              <button type="button"
                class=" relative inline-flex items-center px-4 py-2 border border-cool-gray-300 text-sm leading-5 font-medium text-cool-gray-700 bg-white hover:text-cool-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 active:bg-cool-gray-100 active:text-cool-gray-700 transition ease-in-out duration-150">
                View all
              </button>
              <button type="button"
                class="-ml-px relative inline-flex items-center px-4 py-2 border border-cool-gray-300 text-sm leading-5 font-medium text-cool-gray-700 bg-white hover:text-cool-gray-500 focus:outline-none focus:shadow-outline-blue focus:border-blue-300 active:bg-cool-gray-100 active:text-cool-gray-700 transition ease-in-out duration-150">
                Export
              </button>
            </span>
          </div>
          <LeaderBoard />
        </div>
      </div>
    </div>
  </div>
</template>

<script>
  import LeaderBoard from '@/components/tables/dashboard/leaderboard'
  import AnalyticsCard from '@/components/card/analyticsCard'
  export default {
    components: {
      LeaderBoard,
      AnalyticsCard
    }
  }

</script>

<style>

</style>
