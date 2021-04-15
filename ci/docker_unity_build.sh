#!/usr/bin/env bash

set -e

docker run \
  -e BUILD_NAME \
  -e UNITY_LICENSE_CONTENT \
  -e BUILD_TARGET \
  -w /project/ \
  -v $(pwd):/project/ \
  $IMAGE_NAME \
  /bin/bash -c "/project/ci/unity_license.sh && /project/ci/build.sh"