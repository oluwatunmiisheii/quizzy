<template>
  <div class="container my-5">
    <The-Navigation />
    <nuxt />
    <Auth-Modal />
  </div>
</template>

<script>
import TheNavigation from '@/components/Navigation'
import AuthModal from '@/components/Modals/AuthModal'
export default {
  components: {
    TheNavigation,
    AuthModal
  }
}
</script>