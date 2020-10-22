<template>
  <div class="h-screen flex overflow-hidden bg-cool-gray-100">
    <TheSideBar />
    <div class="flex-1 overflow-auto focus:outline-none" tabindex="0">
      <TheTopbar />
      <main class="flex-1 relative pb-8 z-0 overflow-y-auto">
        <nuxt />
      </main>
    </div>
  </div>
</template>

<script>
import TheSideBar from '@/components/navigation/sidebar'
import TheTopbar from '@/components/navigation/topbar'
export default {
  components: {
    TheSideBar,
    TheTopbar 
  }
}
</script>

