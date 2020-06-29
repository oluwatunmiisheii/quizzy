<template>
  <div class="container my-5">
    <The-Navigation />
    <nuxt />
  </div>
</template>

<script>
import TheNavigation from '@/components/Navigation'

export default {
  components: {
    TheNavigation
  }
}
</script>