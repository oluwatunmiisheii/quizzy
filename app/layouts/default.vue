<template>
  <div>
    <Auth-Modal />
    <The-Navigation />
    <div class="container my-5">
    <nuxt />
    </div>
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